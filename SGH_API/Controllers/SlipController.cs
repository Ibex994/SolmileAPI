using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using System;
using System.IO;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SlipController : ControllerBase
    {
        [HttpPost("GenerateSlip")]
        public IActionResult GenerateSlip([FromBody] ReservationSlipDTO slipDto)
        {
            if (slipDto == null)
                return BadRequest("Invalid slip data.");

            try
            {
                var pdfSlip = new PdfSlipGenerator(slipDto);
                string folderPath = @"C:\Users\Temeb\source\repos\Ibex994\SolmileAPI\SGH_API\GeneratedSlip";
                Directory.CreateDirectory(folderPath); 

                string safeGuestName = string.Join("_", slipDto.FullName.Split(Path.GetInvalidFileNameChars()));
                string filePath = Path.Combine(folderPath, $"ReservationSlip-{slipDto.ReservationCode}-{safeGuestName}.pdf");

                pdfSlip.SaveToFile(filePath);
                using var ms = new MemoryStream();
                Document.Create(container => pdfSlip.Compose(container)).GeneratePdf(ms);
                ms.Position = 0;

                return File(ms.ToArray(), "application/pdf", $"ReservationSlip-{slipDto.ReservationCode}-{safeGuestName}.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] PDF generation failed: {ex}");
                return StatusCode(500, $"Server Error: PDF generation failed. Details: {ex.Message}");
            }
        }
    }
}
