using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class ProjectProcessor
    {
        public static int CreateProject(string name, string description, string imagePath,
                                        string location, int budget, string type)
        {
            ProjectModel data = new ProjectModel
            {
                Name = name,
                Description = description,
                ImagePath = imagePath,
                Location = location,
                Budget = budget,
                Type = type
            };

            string sql = @"insert into dbo.Project (Name, Description, ImagePath,
                                                    Location, Budget, Type)
                            values (@Name, @Description, @ImagePath, @Location,
                                    @Budget, @Type);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ProjectModel> LoadProjects()
        {
            string sql = @"Select Id, Name, Description, ImagePath, 
                           Location, Budget, Type from dbo.Project;";

            return SqlDataAccess.LoadData<ProjectModel>(sql);
        }
    }
}
