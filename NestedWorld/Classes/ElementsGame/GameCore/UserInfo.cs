﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedWorld.Classes.ElementsGame.GameCore
{
    public class UserInfo
    {
        public string Name { get; private set; }
        public string Image { get; private set; }
        public string Background { get; private set; }
        public int Level { get; private set; }

        public int Credit { get; set; }

        public UserInfo(string name, string image,int level)
        {
            this.Name = name;
            this.Image = image;
             this.Level = level;
         }

        public UserInfo(string name, string image, string background, int level, int credit) : this(name, image, level)
        {
            Background = background;
            Credit = credit;
        }

        internal static UserInfo GetYou()
        {
            return new UserInfo("Thomas", "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xlp1/v/t1.0-1/p160x160/10922803_10208019930037378_4351704227098544776_n.jpg?oh=fd24e44ae68ee73ccdb54d4c3f4058a8&oe=569E0588&__gda__=1456530740_111b8273a6a7f61b7a60c9763d4dc96c", "https://scontent-mia1-1.xx.fbcdn.net/hphotos-xfp1/t31.0-8/10984565_10206388417970596_1404781524257364777_o.jpg", 5, 100);
        }
    }
}
