namespace Team4_LegendOfZelda.Item_Classes
{
    class FoodState : ItemState
    {
        public Item UseItem()
        {
            return ItemSpriteFactory.Instance.GetEmptyItem();

        }
    }
}
