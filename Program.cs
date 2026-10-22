using System;

class Program
{
    static void Main(string[] args)
    {
        Vendedor vendedor1 = new Vendedor();
        vendedor1.Idvendedor = "V001";
        vendedor1.Nombre = "Juan";
        vendedor1.Email = "juan@example.com";
        vendedor1.Departamento = "Ventas";
        vendedor1.Activo = true;

        Console.WriteLine("ID del vendedor: " + vendedor1.Idvendedor);
        Console.WriteLine("Nombre del vendedor: " + vendedor1.Nombre);
        Console.WriteLine("Email del vendedor: " + vendedor1.Email);
        Console.WriteLine("Departamento del vendedor: " + vendedor1.Departamento);
        Console.WriteLine("Estado del vendedor: " + vendedor1.Activo);
        Console.WriteLine();

        PackingList packingList1 = new PackingList();
        packingList1.IdPackingList = "PL001";
        packingList1.Descripcion = "ATUN, ALBACORA 120 Lb";
        packingList1.ClienteConsignatario = "SANTA PRISCILA S.A";
        packingList1.Vendedor = "Juan";
        packingList1.FechaEmision = "2026-10-01";
        packingList1.Estado = "Pendiente";
        packingList1.PuertoEmbarque = "Puerto de Guayaquil";
        packingList1.PaisDestino = "Chile";

        Console.WriteLine("ID de la lista de empaque: " + packingList1.IdPackingList);
        Console.WriteLine("Descripción: " + packingList1.Descripcion);
        Console.WriteLine("Cliente consignatario: " + packingList1.ClienteConsignatario);
        Console.WriteLine("Vendedor: " + packingList1.Vendedor);
        Console.WriteLine("Fecha de emisión: " + packingList1.FechaEmision);
        Console.WriteLine("Estado: " + packingList1.Estado);
        Console.WriteLine("Puerto de embarque: " + packingList1.PuertoEmbarque);
        Console.WriteLine("País de destino: " + packingList1.PaisDestino);
        Console.WriteLine();

        FormularioPackingList formulario1 = new FormularioPackingList();
        formulario1.CodigoFormulario = "FR001";
        formulario1.FechaExportacion = "2026-10-01";
        formulario1.FechaProduccion = "2026-09-01";
        formulario1.CodigoLote = "PL001";
        formulario1.CantidadPallets = 10;
        formulario1.DetallePallets = "Pallets de atún";
        formulario1.PaisDestino = "Chile";

        Console.WriteLine("Código del formulario: " + formulario1.CodigoFormulario);
        Console.WriteLine("Fecha de exportación: " + formulario1.FechaExportacion);
        Console.WriteLine("Fecha de producción: " + formulario1.FechaProduccion);
        Console.WriteLine("Código del lote: " + formulario1.CodigoLote);
        Console.WriteLine("Cantidad de pallets: " + formulario1.CantidadPallets);
        Console.WriteLine("Detalle de pallets: " + formulario1.DetallePallets);
        Console.WriteLine("País de destino: " + formulario1.PaisDestino);
        Console.WriteLine();

        InspeccionTemporal inspeccion1 = new InspeccionTemporal();
        inspeccion1.Resultado = "Aprobado";
        inspeccion1.Observaciones = "Sin observaciones adicionales";
        inspeccion1.AprobadoSanitario = true;
        inspeccion1.FormularioPackingList = formulario1;
        inspeccion1.EvaluarEscalaCalidad();

        Console.WriteLine("Evaluación de escala de calidad: " + inspeccion1.Resultado);
        Console.WriteLine("Aprobado sanitario: " + inspeccion1.AprobadoSanitario);
        Console.WriteLine("Observaciones: " + inspeccion1.Observaciones);

        FormularioPackingList formularioAsociado = inspeccion1.FormularioPackingList;
        Console.WriteLine("Datos del formulario asociado:");
        Console.WriteLine("  Código del formulario: " + formularioAsociado.CodigoFormulario);
        Console.WriteLine("  Fecha de exportación: " + formularioAsociado.FechaExportacion);
        Console.WriteLine("  Fecha de producción: " + formularioAsociado.FechaProduccion);
        Console.WriteLine("  Código del lote: " + formularioAsociado.CodigoLote);
        Console.WriteLine("  Cantidad de pallets: " + formularioAsociado.CantidadPallets);
        Console.WriteLine("  Detalle de pallets: " + formularioAsociado.DetallePallets);
        Console.WriteLine("  País de destino: " + formularioAsociado.PaisDestino);
        Console.WriteLine();

        DespachoExportacion despacho1 = new DespachoExportacion("CONT001");
        despacho1.AgregarInspeccion(inspeccion1);
        despacho1.GenerarResumenDespacho();
    }
}