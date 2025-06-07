using System;
using System.Collections;
using System.IO;
using System.Net.Mail;
using System.Net.Mime; 
using System.Numerics;
using PaginaDeBoletos.Clases;
using QRCoder;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace PaginaDeBoletos

{
    public class Transaccion
    {
        public static Queue<MesasPlatino> Cola_MesasPlatino = new Queue<MesasPlatino>();
        public static Queue<VIP> Cola_Vip = new Queue<VIP>();
        public static Queue<General> Cola_General = new Queue<General>();
        public static Queue<Tribuna> Cola_Tribuna = new Queue<Tribuna>();


        public static string Generar_QR(string numerocorrelativo)
        {
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            using var qrData = qrGenerator.CreateQrCode(numerocorrelativo, QRCoder.QRCodeGenerator.ECCLevel.Q);
            using var bitmap = new BitmapByteQRCode(qrData);
            byte[] arraybytes = bitmap.GetGraphic(10);
            string qrtexto = Convert.ToBase64String(arraybytes);
            string imgData = $"data:image/png;base64,{qrtexto}";
            return imgData;

        }

        public static string NoCorrelativo(string dpi, int tipo)
        {
            Random random = new Random();
            int numero = random.Next(100, 999);
            string nocorrelativo = dpi[0].ToString() + dpi[1].ToString() + dpi[2].ToString() + dpi[3].ToString() + tipo.ToString()+numero.ToString();
            return nocorrelativo;
        }

       
        


    }
}
