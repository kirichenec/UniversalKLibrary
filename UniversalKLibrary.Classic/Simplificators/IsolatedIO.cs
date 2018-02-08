using Newtonsoft.Json;
using System.IO;
using System.IO.IsolatedStorage;

namespace UniversalKLibrary.Classic.Simplificators
{
    public static class IsolatedIO
    {
        #region LoadData<T> | Загрузка данных
        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns>Загруженные данные</returns>
        public static T LoadData<T>(string fileName)
        {
            object isoSettings = null;
            try
            {
                var storage = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                if (storage.FileExists(fileName))
                {
                    using (var stream = storage.OpenFile(fileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            string json = reader.ReadToEnd();
                            if (string.IsNullOrEmpty(json) == false)
                            {
                                isoSettings = JsonConvert.DeserializeObject<T>(json);
                            }
                        }
                    }
                }
                storage.Close();
            }
            catch { }

            if (isoSettings == null)
            {
                isoSettings = default(T);
            }
            return (T)isoSettings;
        }
        #endregion

        #region SaveData<T> | Метод сохранения данных в IsolatedStorage
        /// <summary>
        /// Метод сохранения данных в IsolatedStorage
        /// </summary>
        /// <typeparam name="T">Тип сохраняемых данных</typeparam>
        /// <param name="savedData">Сохраняемые данные</param>
        /// <param name="fileName">Имя файла для сохранения</param>
        /// <returns>Успех сохранения</returns>
        public static bool SaveData<T>(
            T savedData,
            string fileName)
        {
            try
            {
                var json = JsonConvert.SerializeObject(savedData);

                #region Save to isolated
                var storage = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                if (storage.FileExists(fileName))
                {
                    storage.DeleteFile(fileName);
                }
                using (var fileStream = storage.CreateFile(fileName))
                {
                    using (var isoFileWriter = new StreamWriter(fileStream))
                    {
                        isoFileWriter.WriteLine(json);
                    }
                }
                storage.Close();
                #endregion

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
