using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    public class AvisosTrafico : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje =  "Sanción  cometida, pague ates de 3 día y se beneficiará de una reducción en la sanción del 50% ha sido enviada por DGT.";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrrarAvisos()
        {
            Console.WriteLine($"Mensaje {mensaje} ha sido enviado por {remitente} el día {fecha}");
        }

    }
}
