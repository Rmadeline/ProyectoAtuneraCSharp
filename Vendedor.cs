using System;

public class Vendedor
{
    private string idvendedor;
    private string nombre;
    private string email;
    private string departamento;
    private bool activo;

    public string Idvendedor
    {
        get { return idvendedor; }
        set { idvendedor = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("El nombre no puede estar vacío");
                return;
            }
            nombre = value;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (value != null && value.Contains("@") && value.Contains("."))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("El correo no es válido");
            }
        }
    }

    public string Departamento
    {
        get { return departamento; }
        set { departamento = value; }
    }

    public bool Activo
    {
        get { return activo; }
        set { activo = value; }
    }
}