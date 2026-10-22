using System;
using System.Collections.Generic;

public class DespachoExportacion
{
    private string idContenedor;
    private string temperaturaConfigurada; 
    private List<InspeccionTemporal> listaInspecciones;

    public DespachoExportacion(string idContenedor)
    {
        IdContenedor = idContenedor;
        temperaturaConfigurada = "-20°C";
        listaInspecciones = new List<InspeccionTemporal>();
    }

    public string IdContenedor
    {
        get { return idContenedor; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: El ID del contenedor no puede estar vacío.");
                return;
            }
            idContenedor = value;
        }
    }

    public string TemperaturaConfigurada
    {
        get { return temperaturaConfigurada; }
        set { temperaturaConfigurada = value; }
    }

    public List<InspeccionTemporal> ListaInspecciones
    {
        get { return listaInspecciones; }
        set { listaInspecciones = value; }
    }

    public void AgregarInspeccion(InspeccionTemporal inspeccion)
    {
        if (inspeccion != null)
        {
            this.listaInspecciones.Add(inspeccion);
        }
        else
        {
            Console.WriteLine("Error: No se puede agregar una inspección nula.");
        }
    }

    public void GenerarResumenDespacho()
    {
        int contadorOK = 0;
        int contadorObservacion = 0;
        int contadorRechazados = 0;
        double totalPallets = 0;

        Console.WriteLine("==========================================");
        Console.WriteLine("   REPORTE FINAL DE DESPACHO - CONTENEDOR ");
        Console.WriteLine("   ID Contenedor: " + idContenedor + " | Temp: " + temperaturaConfigurada);
        Console.WriteLine("==========================================");

        foreach (InspeccionTemporal insp in listaInspecciones)
        {
            string resultado = insp.Resultado;
            FormularioPackingList form = insp.FormularioPackingList;
            
            if (form != null)
            {
                totalPallets += form.CantidadPallets;
            }

            if ("ProductoOK".Equals(resultado))
            {
                contadorOK++;
            }
            else if ("Producto en Observación".Equals(resultado))
            {
                contadorObservacion++;
            }
            else
            {
                contadorRechazados++;
            }
        }

        Console.WriteLine("Total de Lotes Inspeccionados: " + listaInspecciones.Count);
        Console.WriteLine("Total de Pallets Estibados: " + totalPallets);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine(" [✓] Lotes ProductoOK (Aptos directos): " + contadorOK);
        Console.WriteLine(" [!] Lotes en Observación (Aptos zarpe con restricción): " + contadorObservacion);
        Console.WriteLine(" [X] Lotes Rechazados (Fuera de norma): " + contadorRechazados);
        Console.WriteLine("==========================================");
        
        if (contadorRechazados == 0)
        {
            Console.WriteLine("ESTADO: Contenedor CONSOLIDADO Y LISTO para Zarpe Internacional.");
        }
        else
        {
            Console.WriteLine("ESTADO: Contenedor CON ALERTA. Requiere revisión de lotes rechazados.");
        }
    }
}