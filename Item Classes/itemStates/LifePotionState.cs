namespace Team4_LegendOfZelda.Item_Classes
{
    class LifePotionState : ItemState
    {
        public Item UseItem()
        {
            return ItemFactory.Instance.GetEmptyItem();

        }
    }
}
