using Portafolio.web.Models;

namespace Portafolio.web.Services
{
    public interface IProjectRepository
    {
        List<Project> GetProjects();
    }

    public class ProjectRepository:IProjectRepository
    {
        public List<Project> GetProjects() 
        {
            return new List<Project>()
            {
                new Project
                {
                    Title="Sistema de Gestion de Menu",
                    Description ="App de ventas realizad en c# con Window-Form",
                    Link ="https://github.com/Berlyng/ProyectoFinalC-.git",
                    ImageURL = "/images/SistemaDeGestionDeMenu.png"
                },

                new Project
                {
                    Title="Encripatador",
                    Description ="App para encriptar de manera sencilla con html y javascript",
                    Link ="https://github.com/Berlyng/Encriptador.git",
                    ImageURL = "/images/Encriptador.png"
                },
                new Project
                {
                    Title="CRUD Basico",
                    Description ="Crud basico utilizando la arquitectura MVC y entity framework junto a sql server en .net",
                    Link ="https://github.com/Berlyng/Crud_Basico.git",
                    ImageURL = "/images/CRUDbasico.jpg"
                },

                new Project
                {
                    Title="Sistema de Ventas",
                    Description ="App de ventas utilizando MVC",
                    Link ="https://github.com/Berlyng/SalesSystem.git",
                    ImageURL = "/images/salesystem.png"
                }
            };
        }
    }
}
