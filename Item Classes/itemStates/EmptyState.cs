namespace Team4_LegendOfZelda.Item_Classes
{
    class EmptyState : ItemState
    {
        public Item UseItem()
        {
            return ItemSpriteFactory.Instance.GetEmptyItem();
        }
    }
}
