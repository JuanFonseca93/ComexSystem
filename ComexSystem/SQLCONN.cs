using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ComexSystem
{
    class SQLCONN
    {
        private static SqlConnection connect()
        {
            SqlConnection conectar = new SqlConnection("Data Source= DESKTOP-9OJN2F8\\SQLEXPRESS;Initial Catalog=Comex;Integrated Security=True");

            try
            {
                conectar.Open();
                return conectar;
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static DataTable checkUser(String User, String Pass)
        {
            try
            {
                String Querry = "SELECT * FROM Users where usr ='" + User + "' and pss ='" + Pass + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static bool NewUser(String nombre, String User, String Pass, int nivel)
        {
            try
            {
                String Querry = "INSERT INTO Users VALUES('" + User + "','" + Pass + "'," + nivel + ",'" + nombre + "')";
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static bool updUser(int id, String nombre, String User, String Pass, int nivel)
        {
            try
            {
                String Querry = "UPDATE Users SET Nombre ='" + nombre + "', usr='" + User + "', pss ='" + Pass + "', nivel ='" + nivel + "' WHERE id =" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static DataTable getuser()
        {
            try
            {
                String Querry = "SELECT * FROM Users";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static DataTable filtuser(String name)
        {
            try
            {
                String Querry = "SELECT * FROM Users where Nombre like '%" + name + "%'";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static DataTable filprod(String name)
        {
            try
            {
                String Querry = "SELECT * FROM productos where nombre like '%" + name + "%'";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static bool NewProd(String nombre, String Precio, String Existencia, String BC)
        {
            try
            {
                String Querry = "INSERT INTO productos VALUES('" + nombre + "'," + Precio + "," + Existencia + "," + BC + ")";
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static bool UpProd(String nombre, String Precio, String Existencia, String BC, String id)
        {
            try
            {
                String Querry = "update productos Set nombre = '" + nombre + "', precio = " + Precio + ", barcode = " + BC + " where id=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static DataTable getprod()
        {
            try
            {
                String Querry = "SELECT * FROM productos";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static bool UpExis(String BC, String Cantidad)
        {
            try
            {
                String Querry = "update productos Set cantidad = " + Cantidad + " where barcode = " + BC;
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static bool delprod(String id)
        {
            try
            {
                String Querry = "Delete FROM productos where id=" + id;
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static DataTable getprov()
        {
            try
            {
                String Querry = "SELECT * FROM proveedor";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static bool NewProv(String nombre, String tel, String cor, String ub)
        {
            try
            {
                String Querry = "INSERT INTO proveedor VALUES('" + nombre + "','" + tel + "','" + cor + "','" + ub + "')";
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static bool UpProv(String nombre, String tel, String cr, String ub, String id)
        {
            try
            {
                String Querry = "update proveedor Set nombre = '" + nombre + "', telefono = '" + tel + "', correo = '" + cr + "', ubucacion = '"+ub+"' where id=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static bool delprov(String id)
        {
            try
            {
                String Querry = "Delete FROM proveedor where id=" + id;
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static bool NewPred(String Proveedor, String Producto, String cantidad, String fecha)
        {
            try
            {
                String Querry = "INSERT INTO pedidos VALUES(" + Proveedor + ",'" +Producto + "'," + cantidad + ",'" + fecha + "')";
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public static DataTable getped(int id)
        {
            try
            {
                String Querry = "select proveedor.nombre, pedidos.producto, pedidos.cantidad, pedidos.fecha from proveedor inner join pedidos on proveedor.id = pedidos.proveedor where pedidos.id=" + id;
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

    }
}
