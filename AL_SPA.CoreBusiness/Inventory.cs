

namespace AL_SPA.CoreBusiness
{
	public class Inventory
	{
		public EquipmentCategoryEnum EquipmentCategory { get; set; }
		public string Name { get; set; } = string.Empty;
		public EquipmentRarityEnum RarityCategory { get; set; }
		public int Quantity { get; set; } = 0;


	}
}