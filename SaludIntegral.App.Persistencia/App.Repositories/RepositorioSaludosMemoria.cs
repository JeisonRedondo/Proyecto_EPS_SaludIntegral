using System;
using System.Collections.Generic;
using System.Linq;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia.AppRepositories
{
 public class RepositorioSaludosMemoria : IrepositorioSaludos
 //public interface IrepositorioSaludos
 {
  List<Saludo> saludos;
  
  public RepositorioSaludosMemoria()
  {
   saludos = new List<Saludo>()
   {
    new Saludo{Id=1,EnEspañol="Buenos Dias",EnIngles="Good Morning"},
    new Saludo{Id=2,EnEspañol="Buenas Tardes",EnIngles="Good Afternoon"},
    new Saludo{Id=3,EnEspañol="Buenas Noches",EnIngles="Good Evening"}
   };
  }
  public IEnumerable<Saludo> GetAll()
  {
   return saludos;
  }
  public Saludo GetSaludoPorId(int saludoId)
  {
   return saludos.SingleOrDefault(s => s.Id==saludoId);
  }
  public IEnumerable<Saludo> GetSaludosPorFiltro(string filtro=null)
  {
   var saludos = GetAll();
   if (saludos != null)
   {
    if (!String.IsNullOrEmpty(filtro))
    {
     saludos = saludos.Where(s => s.EnEspañol.Contains(filtro));
    }
   }
   return saludos;
  }
  public Saludo Update(Saludo saludoActualizado)
  {
   throw new NotImplementedException();
  }
 }
}