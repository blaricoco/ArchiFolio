using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class DrawingProcessor
    {
        public static int CreateDrawing(string name, string type, string description, 
                                        string ImagePath)
        {
            DrawingModel data = new DrawingModel
            {
                Name = name,
                Type = type,
                Description = description,
                ImagePath = ImagePath
            };

            string sql = @"insert into dbo.Drawing (Name, Type, Description,
                                                    ImagePath)
                            values (@Name, @Type, @Description, @ImagePath);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<DrawingModel> LoadDrawings()
        {
            string sql = @"Select Id, Name, Type, Description, 
                           ImagePath from dbo.Drawing;";

            return SqlDataAccess.LoadData<DrawingModel>(sql);
        }
    }
}
