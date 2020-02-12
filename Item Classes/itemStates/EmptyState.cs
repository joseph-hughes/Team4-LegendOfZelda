namespace Team4_LegendOfZelda.Item_Classes
{
    class EmptyState : ItemState
    {
        public Item UseItem()
        {
            return ItemFactory.Instance.GetEmptyItem();
        }
    }
}
