using System;

public class FormularioPackingList 
{
    private string codigoFormulario;
    private string fechaExportacion;
    private string fechaProduccion;
    private string codigoLote;
    private int cantidadPallets;
    private string detallePallets;
    private string paisDestino;

    public string CodigoFormulario
    {
        get { return codigoFormulario; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El código de formulario no puede estar vacío.");
                return;
            }
            codigoFormulario = value;
        }
    }

    public string FechaExportacion
    {
        get { return fechaExportacion; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: La fecha de exportación no puede estar vacía.");
                return;
            }
            fechaExportacion = value;
        }
    }

    public string FechaProduccion
    {
        get { return fechaProduccion; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: La fecha de producción no puede estar vacía.");
                return;
            }
            fechaProduccion = value;
        }
    }

    public string CodigoLote
    {
        get { return codigoLote; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El código de lote no puede estar vacío.");
                return;
            }
            codigoLote = value;
        }
    }

    public int CantidadPallets
    {
        get { return cantidadPallets; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Error de Invariante: La cantidad de pallets debe ser mayor a 0.");
                return;
            }
            cantidadPallets = value;
        }
    }

    public string DetallePallets
    {
        get { return detallePallets; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El detalle de pallets no puede estar vacío.");
                return;
            }
            detallePallets = value;
        }
    }

    public string PaisDestino
    {
        get { return paisDestino; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El país de destino no puede estar vacío.");
                return;
            }
            paisDestino = value;
        }
    }
}