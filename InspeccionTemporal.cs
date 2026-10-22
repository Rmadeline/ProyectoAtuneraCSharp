using System;

public class InspeccionTemporal
{
    private string idInspeccion;
    private string fechaInspeccion;
    private string resultado;
    private string observaciones;
    private bool aprobadoSanitario;
    private FormularioPackingList formularioPackingList;

    public string IdInspeccion
    {
        get { return idInspeccion; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El ID de inspección no puede estar vacío.");
                return;
            }
            idInspeccion = value;
        }
    }

    public string FechaInspeccion
    {
        get { return fechaInspeccion; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: La fecha de inspección no puede estar vacía.");
                return;
            }
            fechaInspeccion = value;
        }
    }

    public string Resultado
    {
        get { return resultado; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El resultado no puede estar vacío.");
                return;
            }
            resultado = value;
        }
    }

    public string Observaciones
    {
        get { return observaciones; }
        set { observaciones = value; }
    }

    public bool AprobadoSanitario
    {
        get { return aprobadoSanitario; }
        set { aprobadoSanitario = value; }
    }

    public FormularioPackingList FormularioPackingList
    {
        get { return formularioPackingList; }
        set { formularioPackingList = value; }
    }

    public string EvaluarEscalaCalidad()
    {
        if (formularioPackingList == null || 
            string.IsNullOrEmpty(formularioPackingList.FechaProduccion) || 
            string.IsNullOrEmpty(formularioPackingList.FechaExportacion))
        {
            return "ERROR: Faltan datos en el formulario asociado.";
        }

        if (!DateTime.TryParse(formularioPackingList.FechaProduccion, out DateTime produccion) ||
            !DateTime.TryParse(formularioPackingList.FechaExportacion, out DateTime exportacion))
        {
            return "ERROR: Formato de fecha inválido.";
        }

        TimeSpan diferencia = exportacion - produccion;
        long diasTranscurridos = (long)diferencia.TotalDays;

        if (diasTranscurridos < 0)
        {
            this.aprobadoSanitario = false;
            this.resultado = "Rechazado";
            return "Rechazado: La fecha de producción es posterior a la de exportación.";
        }

        if (diasTranscurridos < 30)
        {
            this.aprobadoSanitario = true;
            this.resultado = "ProductoOK";
            return "ProductoOK";
        }
        else if (diasTranscurridos >= 30 && diasTranscurridos <= 60)
        {
            this.aprobadoSanitario = true;
            this.resultado = "Producto en Observación";
            return "Producto en Observación";
        }
        else
        {
            this.aprobadoSanitario = false;
            this.resultado = "Rechazado";
            return "Rechazado";
        }
    }
}