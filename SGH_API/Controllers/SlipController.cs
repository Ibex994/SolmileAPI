using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

public class SlipController : ControllerBase
{
    private readonly IWebHostEnvironment _env;

    public SlipController(IWebHostEnvironment env)
    {
        _env = env;
    }

    [HttpPost("GenerateSlip")]
    public IActionResult GenerateSlip([FromBody] ReservationSlipDTO slipDto)
    {
        if (slipDto == null)
            return BadRequest("Invalid slip data.");

        try
        {
            var pdfSlip = new PdfSlipGenerator(slipDto);
            string folderPath = Path.Combine(_env.ContentRootPath, "GeneratedSlip");
            Directory.CreateDirectory(folderPath);
            string safeGuestName = string.Join("_", slipDto.FullName.Split(Path.GetInvalidFileNameChars()));
            string fileName = $"ReservationSlip-{slipDto.ReservationCode}-{safeGuestName}.pdf";
            string filePath = Path.Combine(folderPath, fileName);

            pdfSlip.SaveToFile(filePath);

            using var ms = new MemoryStream();
            Document.Create(container => pdfSlip.Compose(container)).GeneratePdf(ms);
            ms.Position = 0;

            return File(ms.ToArray(), "application/pdf", fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] PDF generation failed: {ex}");
            return StatusCode(500, $"Server Error: PDF generation failed. Details: {ex.Message}");
        }
    }
}
