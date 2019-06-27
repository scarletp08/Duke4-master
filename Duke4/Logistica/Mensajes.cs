using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4.Logistica
{
    public class Mensajes
    {
        public static string Stg_Campos_EnBlanco = "Complete los campos indicados    ";
        public static void Datosenlimites()
        {
            MessageBox.Show("No hay datos en los límites especificados" + Environment.NewLine + " Verifique los parámetros"
         , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult Msgb_Eliminar_Fila()
        {
            return MessageBox.Show("Desea eliminar la fila seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void Msgb_Registro_No_Cuadrado()
        {
            MessageBox.Show("La entrada no esta cuadrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Msgb_Registro_Sin_Itbis()
        {

            MessageBox.Show("Esta factura no tiene Itbis, no puede aplicar itbis en este registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Msgb_Registro_Mayor_30dias()
        {

            MessageBox.Show("Esta factura tiene mas de 30 días, no se deberia aplicar itbis", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Msgb_Itbis_Mayor_Que(double itbiscalculado)
        {
            MessageBox.Show("Itbis no puede ser mayor que " + itbiscalculado.ToString("N2"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Msgb_Continuar_Modificacion_Registro()
        {
            return MessageBox.Show("Desea continuar con la modificación del registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static void Msgb_Registro_Desactivado()
        {
            MessageBox.Show("Este registro está desactivado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Msgb_Registro_Activado()
        {
            MessageBox.Show("Este registro está activado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Msgb_Registro_NoExiste()
        {
            MessageBox.Show("Este registro no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Msgb_Registro_SalvadoExito()
        {
            MessageBox.Show("Registros salvados exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Msgb_NoFacturas_EnMoneda()
        {
            MessageBox.Show("Este cliente no tiene documentos pendiente de este tipo de moneda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Msgb_NoCobros_CliContado()
        {
            MessageBox.Show("No puede registrar cobros al cliente de contado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_NoRegistro_CliContado()
        {
            MessageBox.Show("No puede registrar factura al cliente de contado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_NoChequeFuturo_CliContado()
        {
            MessageBox.Show("No puede registrar cheques futuros al cliente de contado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Msgb_NoDebCre_CliContado()
        {
            MessageBox.Show("No puede registrar nota de crédito/débito al cliente de contado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_NoCobro_Adelantado_CliContado()
        {
            MessageBox.Show("No puede registrar cobro Adelantado al cliente de contado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void Msgb_MontoFuera_Limite()
        {
            MessageBox.Show("La cantidad a abonar no puede ser mayor que la pendiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Msgb_Desc_Invalido()
        {
            MessageBox.Show("El descuento no es válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_Ret_ISR_Invalida()
        {
            MessageBox.Show("La Retención no puede ser mayor al monto de la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_Ret_Itbis_Invalida()
        {
            MessageBox.Show("La Retención de Itbis no puede ser mayor al Itbis de la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_Ret_Itbis_Sinpago()
        {
            MessageBox.Show("No se puede aplicar retención de Itbis sin pago a la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Msgb_Ret_ISR_Sinpago()
        {
            MessageBox.Show("No se puede aplicar retención de ISR sin pago a la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Msgb_Desc_Sinpago()
        {
            MessageBox.Show("No se puede aplicar descuento sin pago a la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Msgb_DatosporProcesar()
        {
            return MessageBox.Show("Hay datos para procesar, Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static void Msgb_Cliente_Sindeposito()
        {
            MessageBox.Show("Este cliente no tiene depósito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Msgb_Datos_Limites()
        {
            MessageBox.Show("No hay datos en los límites especificados" + Environment.NewLine + " Verifique los parámetros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Msgb_Tiene_Movimiento_No_Modificar()
        {
            MessageBox.Show("El registro tiene movimientos no se puede modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Msgb_Tiene_Movimiento_No_Cancelar()
        {
            MessageBox.Show("El registro tiene movimientos no se puede cancelar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Msgb_Registro_Cancelado_No_Modificar()
        {
            MessageBox.Show("El registro está cancelado. No se puede modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Msgb_Registro_Pendiente()
        {
            MessageBox.Show("Este cliente tiene registro pendiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Msgb_Mismo_Registro(string numero, DateTime dtfecha)
        {
            MessageBox.Show("Ya existe un registro con esa refencia y con el mismo cliente " + Environment.NewLine + "Número " + numero + " de fecha " + dtfecha.ToString("dd/MM/yyyy") + Environment.NewLine + "No se puede duplicar","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }          
    }
}
