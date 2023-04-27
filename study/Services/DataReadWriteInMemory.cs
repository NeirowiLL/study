using System;
namespace study
{
    public class DataReadWriteInMemory
    {
        private static List<UserScoreStorage> _dataStorage { get; set; } = new();

        public void SaveData(UserScoreStorage UserScoreStorage)
        {
            _dataStorage.Add(UserScoreStorage);
        }
        public UserScoreStorage[] ReadData()
        {
            return _dataStorage.ToArray();
        }
    }

    public class UserScoreStorage
    {
        public string UserId { get; set; }
        public int UserScore { get; set; }
        public DateTime Date { get; internal set; }
    }

    public class UserScoreProcessor
    {
        private DataReadWriteInMemory _dataStorage;

        public UserScoreProcessor()
        {
            _dataStorage = new DataReadWriteInMemory();
        }

        public void SaveUserScore(string userId, int userScore)
        {
            UserScoreStorage userScoreStorage = new UserScoreStorage()
            {
                UserId = userId,
                UserScore = userScore,
                Date = DateTime.Now
            };
            _dataStorage.SaveData(userScoreStorage);
        }
    }
}

