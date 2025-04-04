using System;
using System.Collections.Generic;
using System.Linq;
using OSPeConTI.SumariosIERIC.Domain.SeedWork;

namespace OSPeConTI.SumariosIERIC.Domain.Enums;
public class Estado : Enumeration
{
    public Estado(int id, string nombre) : base(id, nombre)
    {
    }
    public static Estado Pendiente = new Estado(1, nameof(Pendiente).ToLowerInvariant());
    public static Estado Inviable = new Estado(2, nameof(Inviable).ToLowerInvariant());
    public static Estado Finalizado = new Estado(3, nameof(Finalizado).ToLowerInvariant());

    public static IEnumerable<Estado> List() =>
               new[] { Pendiente, Inviable, Finalizado };
    public static Estado FromName(string nombre)
    {
        var state = List()
            .SingleOrDefault(s => String.Equals(s.Nombre, nombre, StringComparison.CurrentCultureIgnoreCase));

        if (state == null)
        {
            throw new Exception($"Possible values for Estado: {String.Join(",", List().Select(s => s.Nombre))}");
        }

        return state;
    }

    public static Estado From(int id)
    {
        var state = List().SingleOrDefault(s => s.Id == id);

        if (state == null)
        {
            throw new Exception($"Possible values for Estado: {String.Join(",", List().Select(s => s.Nombre))}");
        }

        return state;

    }

}