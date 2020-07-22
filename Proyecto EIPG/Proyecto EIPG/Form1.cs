using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos_usuarios.cache;

namespace Proyecto_EIPG
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    int Valor = 0, Cantidad = 0; //variables bandera
        //    DateTime Fecha_Tonta = DateTime.Today; //cargamos la fecha actual como una fecha tonta
        //    Procedimientos_Almacenados proc = new Procedimientos_Almacenados(); //instanciamos la clase de procedimiento almacenados

        //    DateTime Fecha = DateTime.Today; //cargamos la fecha actual de nuevo ya que esta sera la varible principal en caso a fecha
        //    //validamos si el mes 
        //    if (Fecha.ToString("MM/yyy").Equals(Fecha.ToString("01/yyy")) || Fecha.ToString("MM/yyy").Equals(Fecha.ToString("12/yyy")))
        //    {
        //    }
        //    else
        //    {
        //        MessageBox.Show(Fecha_Tonta.ToString("01/MM/yyy"));
        //        if (Valor == 0)
        //        {
        //            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("01/MM/yyy")));
        //        }
        //        else
        //            if (Valor == 0)
        //            {
        //                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("02/MM/yyy")));
        //            }
        //            else
        //                if (Valor == 0)
        //                {
        //                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("03/MM/yyy")));
        //                }
        //                else
        //                   if (Valor == 0)
        //                    {
        //                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("04/MM/yyy")));
        //                    }
        //                    else
        //                        if (Valor == 0)
        //                        {
        //                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("05/MM/yyy")));
        //                        }
        //                        else
        //                            if (Valor == 0)
        //                            {
        //                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("06/MM/yyy")));
        //                            }
        //                            else
        //                                if (Valor == 0)
        //                                {
        //                                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("07/MM/yyy")));
        //                                }
        //                                else
        //                                    if (Valor == 0)
        //                                    {
        //                                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("08/MM/yyy")));
        //                                    }
        //                                    else
        //                                        if (Valor == 0)
        //                                        {
        //                                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("09/MM/yyy")));
        //                                        }
        //                                        else
        //                                            if (Valor == 0)
        //                                            {
        //                                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("10/MM/yyy")));
        //                                            }
        //                                            else
        //                                                if (Valor == 0)
        //                                                {
        //                                                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("11/MM/yyy")));
        //                                                }
        //                                                else
        //                                                    if (Valor == 0)
        //                                                    {
        //                                                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("12/MM/yyy")));
        //                                                    }
        //                                                    else
        //                                                        if (Valor == 0)
        //                                                        {
        //                                                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("13/MM/yyy")));
        //                                                        }
        //                                                        else
        //                                                            if (Valor == 0)
        //                                                            {
        //                                                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("14/MM/yyy")));
        //                                                            }
        //                                                            else
        //                                                                if (Valor == 0)
        //                                                                {
        //                                                                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("15/MM/yyy")));
        //                                                                }
        //                                                                else
        //                                                                    if (Valor == 0)
        //                                                                    {
        //                                                                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("16/MM/yyy")));
        //                                                                    }
        //                                                                    else
        //                                                                        if (Valor == 0)
        //                                                                        {
        //                                                                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("17/MM/yyy")));
        //                                                                        }
        //                                                                        else
        //                                                                            if (Valor == 0)
        //                                                                            {
        //                                                                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("18/MM/yyy")));
        //                                                                            }
        //                                                                            else
        //                                                                                if (Valor == 0)
        //                                                                                {
        //                                                                                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("19/MM/yyy")));
        //                                                                                }
        //                                                                                else
        //                                                                                    if (Valor == 0)
        //                                                                                    {
        //                                                                                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("20/MM/yyy")));
        //                                                                                    }
        //                                                                                    else
        //                                                                                        if (Valor == 0)
        //                                                                                        {
        //                                                                                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("21/MM/yyy")));
        //                                                                                        }
        //                                                                                        else
        //                                                                                            if (Valor == 0)
        //                                                                                            {
        //                                                                                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("22/MM/yyy")));
        //                                                                                            }
        //                                                                                            else
        //                                                                                                if (Valor == 0)
        //                                                                                                {
        //                                                                                                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("23/MM/yyy")));
        //                                                                                                }
        //                                                                                                else
        //                                                                                                    if (Valor == 0)
        //                                                                                                    {
        //                                                                                                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("24/MM/yyy")));
        //                                                                                                    }
        //                                                                                                    else
        //                                                                                                        if (Valor == 0)
        //                                                                                                        {
        //                                                                                                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("25/MM/yyy")));
        //                                                                                                        }
        //                                                                                                        else
        //                                                                                                            if (Valor == 0)
        //                                                                                                            {
        //                                                                                                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("26/MM/yyy")));
        //                                                                                                            }
        //                                                                                                            else
        //                                                                                                                if (Valor == 0)
        //                                                                                                                {
        //                                                                                                                    Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("27/MM/yyy")));
        //                                                                                                                }
        //                                                                                                                else
        //                                                                                                                    if (Valor == 0)
        //                                                                                                                    {
        //                                                                                                                        Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("28/MM/yyy")));
        //                                                                                                                    }
        //                                                                                                                    else
        //                                                                                                                        if (Valor == 0)
        //                                                                                                                        {
        //                                                                                                                            Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("29/MM/yyy")));
        //                                                                                                                        }
        //                                                                                                                        else
        //                                                                                                                            if (Valor == 0)
        //                                                                                                                            {
        //                                                                                                                                Valor = proc.consultar_fecha(Convert.ToDateTime(Fecha_Tonta.ToString("30/MM/yyy")));
        //                                                                                                                            }
        //                                                                                                                            else
        //        if (Valor == 0)
        //        {
        //            Cantidad = int.Parse(proc.verificar_cantidad_cuotas());
        //            if (Cantidad == 0 || Cantidad == 10)
        //            {
        //                Cantidad = 1;
        //                proc.cargar_matricula_pago(Cantidad, Fecha);
        //                proc.insertar_saldo();
        //                proc.Descuento_Alumno();

        //            }
        //            else
        //            {
        //                proc.cargar_matricula_pago(Cantidad + 1, Fecha);
        //                proc.insertar_saldo();
        //                proc.Descuento_Alumno();
        //            }
        //        }
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton ingresar
            Procedimientos_Almacenados pro = new Procedimientos_Almacenados();//instancia a la calse de procedimientos almacenados
            if (Txt_Usuario.Text.Equals("") || Txt_Contrasena.Text.Equals(""))//verifica que ambos campos no esten vacios en caso contrario muestra la advertencia
            {
                MessageBox.Show("Error, No puede dejar campos vacios");
            }
            else
            {
                //si no estan vacios entra a la decision
                //valida que los datos ingresados sean los correctos en caso contrario muestra una advertencia
                //regresa una variable llamada acceso si el acceso == 0 no esta registrado
                if (pro.login(Txt_Usuario.Text, Txt_Contrasena.Text) == 0)
                {
                    MessageBox.Show("usuario y contrasena incorrecros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Txt_Usuario.Text = "";
                    Txt_Contrasena.Text = "";
                }
                else
                {
                    //si los datos son correctos hace una instancia al menu total y a la clase de procedimiento almacenado
                    menu principal = new menu();
                    Procedimientos_Almacenados proc = new Procedimientos_Almacenados();
                    if (pro.Acceso == 1)//si la variable acceso == 1 tiene acceso a todo el sistema, abrimos el menu y mandamos a cargar los datos del usuario
                    {
                        menu me = new menu();
                         cache_usuario.Usuario = proc.busqueda_nombre_usuario(Txt_Usuario.Text,Txt_Contrasena.Text);
                        cache_usuario.Id = proc.busqueda_identidad_usuario(Txt_Usuario.Text, Txt_Contrasena.Text);

                        this.Hide();
                        principal.Show();
                    }
                    if (pro.Acceso == 2) // si la variable acceso == 2 abre el menu administrativo y manda a cargar los datos del usuario
                    {
                        Menu_Admin ma = new Menu_Admin();
                        cache_usuario.Usuario = proc.busqueda_nombre_usuario(Txt_Usuario.Text, Txt_Contrasena.Text);
                        cache_usuario.Id = proc.busqueda_identidad_usuario(Txt_Usuario.Text, Txt_Contrasena.Text);
                        this.Hide();
                        ma.Show();
                    }

                    if (pro.Acceso == 3)//si la variable acceso == 3 abre el menu contable y manda a cargar los datos del usuario
                    {
                        Menu_Contabilidad mc = new Menu_Contabilidad();
                        cache_usuario.Usuario = proc.busqueda_nombre_usuario(Txt_Usuario.Text, Txt_Contrasena.Text);
                        cache_usuario.Id = proc.busqueda_identidad_usuario(Txt_Usuario.Text, Txt_Contrasena.Text);
                        this.Hide();
                        mc.Show();
                    }
                }
            }
            
        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }

        private void txtboxUsuario_Validated(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña frc = new RecuperarContraseña();
            frc.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //validacion en caso que desee o por accidente de click en cerrar el formulario
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                Application.Exit();
            }

    
        }

        private void txtboxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void txtboxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
    }
}
