using Autos.Repository.Models;

namespace Autos.Test.Builders;

public class MarcasAutoBuilder
{
    private Guid _id = Guid.NewGuid();
    private string _marca = "Toyota";
    private string _modelo = "Rav4";
    private int _anno = 2024;
    private string _color = "Blanco";
    private bool _isActive = true;
    private string _serial = "1234567890";

    private MarcasAutoBuilder()
    {

    }

    public static MarcasAutoBuilder Builder()
    {
        return new MarcasAutoBuilder();
    }

    public MarcasAuto Build()
    {
        return new MarcasAuto
        {
            Id = _id,
            Marca = _marca,
            Modelo = _modelo,
            Anno = _anno,
            Color = _color,
            IsActive = _isActive,
            Serial = _serial
        };
    }

    internal MarcasAutoBuilder WithMarca(string marca)
    {
        _marca = marca;
        return this;
    }
}
