using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QRCoder;
using System.IO;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using System;
using QuestPDF.Helpers;

public class PdfSlipGenerator : IDocument
{
    private readonly ReservationSlipDTO slip;

    public PdfSlipGenerator(ReservationSlipDTO slip)
    {
        this.slip = slip;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A5);
            page.Margin(30);
            page.Background(Colors.Black);
            page.Header().Column(header =>
            {
                header.Item().Row(row =>
                {
                   
                    row.ConstantItem(60).Column(col =>
                    {
                        try
                        {
                            var imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\Temeb\\source\\repos\\Ibex994\\SolmileAPI\\SGH_API\\Asset", "Black_and_Gold_Vintage_Luxury_Hotel_Logo-removebg-preview.png");

                            if (!File.Exists(imagePath))
                                throw new FileNotFoundException($"Image not found at: {imagePath}");

                            using var imageStream = File.OpenRead(imagePath);
                            col.Item().Image(imageStream).FitArea();
                        }
                        catch (Exception ex)
                        {
                            col.Item().Text($"[Logo Error: {ex.Message}]").FontSize(8).Italic().FontColor(Colors.Red.Medium);
                        }

                    });

                    row.RelativeItem().Column(col =>
                    {
                        col.Item().AlignCenter().Text("Solmile Guesthouse")
                            .FontSize(16).Bold().FontColor(Colors.Yellow.Lighten1);

                        col.Item().AlignCenter().Text("Reservation Slip")
                            .FontSize(14).SemiBold().FontColor(Colors.Yellow.Lighten1); 
                    });

                    row.ConstantItem(60).Column(col =>
                    {
                        try
                        {
                            col.Item().Image(GetQrCodeImage(slip.ReservationCode)).FitArea();
                        }
                        catch
                        {
                            col.Item().Text("[QR Code Error]").FontSize(8).Italic().FontColor(Colors.Red.Medium);
                        }
                    });
                });

                header.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
            });

            page.Content().PaddingVertical(30).AlignCenter().Column(col =>
            {
                col.Spacing(25);

                col.Item().Text($"👤 Guest Name: {slip.FullName ?? "N/A"}")
                    .FontSize(12).FontColor(Colors.Yellow.Lighten1);

                col.Item().Text($"🛏 Room Number: {slip.RoomNumber}")
                    .FontSize(12).FontColor(Colors.Yellow.Lighten1);

                col.Item().Text($"📅 Check-In: {slip.CheckIn:yyyy-MM-dd}")
                    .FontSize(12).FontColor(Colors.Yellow.Lighten1);

                col.Item().Text($"📅 Check-Out: {slip.CheckOut:yyyy-MM-dd}")
                    .FontSize(12).FontColor(Colors.Yellow.Lighten1);

                col.Item().Text($"💰 Amount Paid: {slip.AmountPaid:C}")
                    .FontSize(12).Bold().FontColor(Colors.Yellow.Lighten1); 

                col.Item().Text($"💳 Payment Method: {slip.PaymentMethod ?? "N/A"}")
                    .FontSize(12).FontColor(Colors.Yellow.Lighten1);

                col.Item().Text($"🧾 Reservation Code: {slip.ReservationCode ?? "N/A"}")
                    .FontSize(12).Italic().FontColor(Colors.Yellow.Lighten1);
            });

            page.Footer().PaddingTop(15).AlignCenter().Text("Thank you for choosing Solmile Guesthouse")
                .Italic().FontSize(10).FontColor(Colors.Yellow.Lighten1);
        });
    }

private byte[] GetQrCodeImage(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("QR code data is null or empty.");

        using var qrGenerator = new QRCodeGenerator();
        using var qrCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
        var qrCode = new BitmapByteQRCode(qrCodeData);
        return qrCode.GetGraphic(20);
    }

    public void SaveToFile(string filePath)
    {
        Document.Create(container => Compose(container)).GeneratePdf(filePath);
    }
}
