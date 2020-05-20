using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    // not storing data, only for processing information 
    public static class ProfileProcessor
    {
        public static int CreateProfile(string firstName,string lastName, string emailAddress, 
            string description, string imagePath, string profession)
        {
            ProfileModel data = new ProfileModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Description = description,
                ImagePath = imagePath,
                Profession = profession
            };

            //string sql = @"insert into dbo.Profile (FirstName, LastName, EmailAddress,
            //                                        Description, ImagePath, Profession)
            //                values (@FirstName, @LastName, @EmailAddress, @Description,
            //                        @ImagePath, @Profession);";
            string sql = @"dbo.spProfile_Create @FirstName";

            return SqlDataAccess.SaveData(sql, data);
            //dont have to specify type becasue savadata is of type T
        }

        public static List<ProfileModel> LoadProfiles()
        {
            string sql = @"Select Id, FirstName, LastName, EmailAddress, 
                           Description, ImagePath, Profession from dbo.Profile;";
            return SqlDataAccess.LoadData<ProfileModel>(sql);
            // have to specify type of model because there is no mention of generic value 
        }

        public static List<ProfileModel> UpdateProfile(int id, string firstName, string lastName, string emailAddress,
            string description, string imagePath, string profession)
        {
            string sql = @"";

            return SqlDataAccess.LoadData<ProfileModel>(sql);
        }
    }
}
