using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 音樂評分排序系統
{
    public class Music
    {
        public Music()
        {
            AllMusic = new DirectoryInfo(Link).GetFiles();
            Array.Sort(AllMusic, new FileLastTimeComparer());
            Array.Reverse(AllMusic);
            random = new Random();
        }

        Random random;
        public FileInfo[] AllMusic { get; private set; }
        public const string Link = @"E:\音樂\";
        public const string AllNameLink = @"音樂名稱清單.txt";
        public const string AllMarkLink = @"音樂分數清單.txt";
        int position = -1;

        public string Status(PlayStatus status,string name)
        {
            if (status == PlayStatus.Random)
                return RandomMusic;
            else if (status == PlayStatus.SequentialHead)
                return Sequential();
            else if (status == PlayStatus.SequentialNow)
                return Sequential(name);
            return null;
        }

        protected bool Contains(string name)
        {
            for (int i = 0; i < AllMusic.Length; i++)
            {
                if (AllMusic[i].FullName == name)
                    return true;
            }
            return false;
        }

        string RandomMusic
        {
            get
            {
                position = -1;
                return AllMusic[random.Next(AllMusic.Length + 1)].FullName;
            }
        }

        string Sequential()
        {
            position++;
            return AllMusic[position].FullName;
        }

        string Sequential(string nowName)
        {
            for (int i = 0; i < AllMusic.Length; i++)
            {
                if (AllMusic[i].FullName == nowName)
                {
                    Position = i + 1;
                    break;
                }
            }
            return AllMusic[position].FullName;
        }

        int Position
        {
            get => position;
            set
            {
                position = value;
                if (position > AllMusic.Length - 1)
                    position = 0;
            }
        }
    }
}