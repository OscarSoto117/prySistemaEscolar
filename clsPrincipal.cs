using System;
using System.Collections.Generic;
using System.Text;

namespace prySistemaEscolar
{
    internal class clsPrincipal
    {
        //este es un objeto de tipo form
        private Form misformsabiertos;

        public void agregarAlContenedor(Form formulario, Panel panel)
        {
            //verifica si esta abierrto un formulario
            if (misformsabiertos != null)
            {
                misformsabiertos.Close(); //cierra la instancia
                misformsabiertos.Dispose(); //libera de memoria
            }

            misformsabiertos = formulario;
            panel.Controls.Clear();

            formulario.TopLevel = false;//indica que el formulario no es una ventana independiente
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock = DockStyle.Fill;

            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    }
}
