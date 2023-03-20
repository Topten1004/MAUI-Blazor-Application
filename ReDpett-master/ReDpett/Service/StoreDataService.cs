using Newtonsoft.Json;

namespace ReDpett.Service
{
    public class StoreDataService : ISaveDataService
    {
        string applicationFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ReDpettApp");
        
        private ListAppDataService _data;

        public StoreDataService(ListAppDataService data)
        {
            _data = data;
        }

        public async Task<ListAppDataService> GetDataFromOfflineDB()
        {
            try
            {
                if (!Directory.Exists(applicationFolderPath))
                {
                    Directory.CreateDirectory(applicationFolderPath);
                }
                string databaseFileName = Path.Combine(applicationFolderPath, "Project.json");

                var str = File.ReadAllText(databaseFileName);
                if (!String.IsNullOrEmpty(str))
                {
                    var listAppDataService = JsonConvert.DeserializeObject<ListAppDataService>(str);
                    _data = listAppDataService;
                }
                
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Alert!", "Data was retrived from local db. Error Occured.." + ex.Message, "OK");
            }
            return _data;
        }

        public async void InsertOfflineDB(ListAppDataService __data)
        {
            try
            {
                if (!Directory.Exists(applicationFolderPath))
                {
                    Directory.CreateDirectory(applicationFolderPath);
                }
                string databaseFileName = Path.Combine(applicationFolderPath, "Project.json");

                string req_json_string = JsonConvert.SerializeObject(__data);
                File.WriteAllText(databaseFileName, req_json_string);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Alert!", "Data was not saved in local db. Error Occured.." + ex.Message, "OK");
            }
        }

    }
}
