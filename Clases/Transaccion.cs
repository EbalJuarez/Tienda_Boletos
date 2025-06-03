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
        public static Queue<MesasPlatino> Cola_MesasPlatino = new Queue<MesasPlatino>();
        public static Queue<VIP> Cola_Vip = new Queue<VIP>();
        public static Queue<General> Cola_General = new Queue<General>();
        public static Queue<Tribuna> Cola_Tribuna = new Queue<Tribuna>();


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
            string nocorrelativo = dpi[0].ToString() + dpi[1].ToString() + dpi[2].ToString() + dpi[3].ToString() + tipo.ToString();
            return nocorrelativo;
        }

        public static void GenerarPDF()
        {
            
           
        }
    }
}
