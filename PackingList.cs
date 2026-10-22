using System;

public class PackingList
{
    private string idPackingList;
    private string descripcion;
    private string clienteConsignatario;
    private string vendedor;
    private string fechaEmision;
    private string estado;
    private string puertoEmbarque;
    private string paisDestino;

    public string IdPackingList
    {
        get { return idPackingList; }
        set { idPackingList = value; }
    }

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public string ClienteConsignatario
    {
        get { return clienteConsignatario; }
        set { clienteConsignatario = value; }
    }

    public string Vendedor
    {
        get { return vendedor; }
        set { vendedor = value; }
    }

    public string FechaEmision
    {
        get { return fechaEmision; }
        set { fechaEmision = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public string PuertoEmbarque
    {
        get { return puertoEmbarque; }
        set { puertoEmbarque = value; }
    }

    public string PaisDestino
    {
        get { return paisDestino; }
        set { paisDestino = value; }
    }
}