using System.Collections.Generic;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia.AppRepositories
{
 public interface IrepositorioSaludos
 {
  IEnumerable<Saludo> GetAll();
  IEnumerable<Saludo> GetSaludosPorFiltro(string filtro);
  Saludo GetSaludoPorId(int saludoID);
  Saludo Update(Saludo saludoActualizado);
 }
}