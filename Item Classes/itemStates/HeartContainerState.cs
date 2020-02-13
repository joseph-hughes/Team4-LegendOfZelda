namespace Team4_LegendOfZelda.Item_Classes
{
    class HeartContainerState : ItemState
    {
        public Item UseItem()
        {
            return ItemFactory.Instance.GetEmptyItem();

        }
    }
}
