using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameLib;

namespace CardGameImpl
{
    internal static class ImageMapper
    {
        public static Image MapCard(Card card)
        {
            try
            {
                return (Image)CardResources.ResourceManager.GetObject($"_{(int)card.Value}_{(int)card.Suit}");
            }
            catch
            {
                return (Image)CardResources.placeholder;
            }
        }

        public static Image MapResult(bool result)
        {
            try
            {
                return (Image)(result ? ResultResources.tick : ResultResources.cross);
            }
            catch { return (Image)ResultResources.cross;}
        }

        public static Image MapSuit(CardSuit suit)
        {
            try
            {
                return (Image)SuitResources.ResourceManager.GetObject(suit.ToString().ToLower());
            }
            catch
            {
                return null;
            }
        }
    }
}
