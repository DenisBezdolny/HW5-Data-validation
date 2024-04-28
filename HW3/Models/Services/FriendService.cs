using HW4.Data;
using HW4.Models.Abstract_entities;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HW4.Models.Entities
{
    public class FriendService : IFriendService
    {

        private readonly FriendContext _context;
        public FriendService() { }

        public FriendService(FriendContext context)
        {
            _context = context;
        }


        public bool Create(Friend friend)
        {
            try
            {
                _context.Friend.Add(friend);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public List<Friend> GetFriends()
        {
            return _context.Friend.ToList();
        }

        public void RemoveFriend(int friendId)
        {
            var friend = _context.Friend.FirstOrDefault(f => f.Id == friendId);
            if (friend != null)
            {
                _context.Friend.Remove(friend);
                _context.SaveChanges();
            }
        }



        //public List<FriendService> GetFriends()
        //{
        //    string filePath = "friends.json";
        //    if (File.Exists(filePath))
        //    {
        //        string jsonString = File.ReadAllText(filePath);
        //        FriendService[] friends = JsonSerializer.Deserialize<FriendService[]>(jsonString);
        //        return friends.ToList();
        //    }
        //    else
        //    {
        //        return new List<FriendService>();
        //    }
        //}

        //public void CreateFriendsFile()
        //{
        //    string filePath = "friends.json";
        //    if (!File.Exists(filePath))
        //    {
        //        List<FriendService> friendList = new List<FriendService>()
        //        {
        //            new FriendService{ FriendId = 1,  FriendName = "Ivan",  Place = "Minsk" },
        //            new FriendService{ FriendId = 2,  FriendName = "Sergey", Place = "Grodno" },
        //            new FriendService{ FriendId = 3,  FriendName = "Maria",  Place = "Gomel" }
        //        };

        //        string jsonString = JsonConvert.SerializeObject(friendList);
        //        File.WriteAllText(filePath, jsonString);
        //    }
        //}
    }
}
