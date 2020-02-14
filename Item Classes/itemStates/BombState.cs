namespace Team4_LegendOfZelda.Item_Classes
{
    class BombState : ItemState
    {
        public Item UseItem()
        {
            return ItemSpriteFactory.Instance.GetEmptyItem();
        }
    }
}
