using System.Collections;
using System;
using PaginaDeBoletos.Clases;
using System.Numerics;
using QRCoder;
using iTextSharp.text.pdf.qrcode;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
namespace PaginaDeBoletos

{
    public class Transaccion
    {
        public static Queue<Boletos> Cola_Transacciones = new Queue<Boletos>();
    

        public static string  Generar_QR(string numerocorrelativo)
        {
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            using var qrData = qrGenerator.CreateQrCode(numerocorrelativo, QRCoder.QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new QRCoder.PngByteQRCode(qrData);
            byte[] qrBytes = qrCode.GetGraphic(20);
            return Convert.ToBase64String(qrBytes);
        }

        public static string NoCorrelativo(string dpi, int tipo)
        {
            string nocorrelativo;
            nocorrelativo = dpi[0] + dpi[1] + dpi[2] + dpi[3] + tipo.ToString();
            return nocorrelativo;
        }

        public static void GenerarPDF()
        {
            
           
        }
    }
}
