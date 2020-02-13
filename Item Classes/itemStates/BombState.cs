namespace Team4_LegendOfZelda.Item_Classes
{
    class BombState : ItemState
    {
        public Item UseItem()
        {
            return ItemFactory.Instance.GetEmptyItem();
        }
    }
}
