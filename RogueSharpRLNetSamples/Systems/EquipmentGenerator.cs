using RogueSharpRLNetSamples.Equipment;
using System.Collections.Generic;

namespace RogueSharpRLNetSamples.Systems
{
    public class EquipmentGenerator
    {
        private readonly Pool<Core.Equipment> _equipmentPool;

        public EquipmentGenerator(int level)
        {
            _equipmentPool = new Pool<Core.Equipment>();

            if (level <= 3)
            {
                _equipmentPool.Add(BodyEquipment.Leather(), 20);
                _equipmentPool.Add(HeadEquipment.Leather(), 20);
                _equipmentPool.Add(FeetEquipment.Leather(), 20);
                _equipmentPool.Add(HandEquipment.Dagger(), 25);
                _equipmentPool.Add(HandEquipment.Sword(), 5);
                _equipmentPool.Add(HeadEquipment.Chain(), 5);
                _equipmentPool.Add(BodyEquipment.Chain(), 5);
            }
            else if (level <= 6)
            {
                _equipmentPool.Add(BodyEquipment.Chain(), 20);
                _equipmentPool.Add(HeadEquipment.Chain(), 20);
                _equipmentPool.Add(FeetEquipment.Chain(), 20);
                _equipmentPool.Add(HandEquipment.Sword(), 15);
                _equipmentPool.Add(HandEquipment.Axe(), 15);
                _equipmentPool.Add(HeadEquipment.Plate(), 5);
                _equipmentPool.Add(BodyEquipment.Plate(), 5);
            }
            else
            {
                _equipmentPool.Add(BodyEquipment.Plate(), 25);
                _equipmentPool.Add(HeadEquipment.Plate(), 25);
                _equipmentPool.Add(FeetEquipment.Plate(), 25);
                _equipmentPool.Add(HandEquipment.TwoHandedSword(), 25);
            }
        }

        public List<Core.Equipment> CreateShopEquipmentList()
        {
            List<Core.Equipment> shopEquipment = new List<Core.Equipment>();

            // Kopfausrüstung hinzufügen
            shopEquipment.Add(HeadEquipment.Leather());
            shopEquipment.Add(HeadEquipment.Chain());
            shopEquipment.Add(HeadEquipment.Plate());

            // Handausrüstung hinzufügen
            shopEquipment.Add(HandEquipment.Dagger());
            shopEquipment.Add(HandEquipment.Sword());
            shopEquipment.Add(HandEquipment.Axe());
            shopEquipment.Add(HandEquipment.TwoHandedSword());

            // Fußausrüstung hinzufügen
            shopEquipment.Add(FeetEquipment.Leather());
            shopEquipment.Add(FeetEquipment.Chain());
            shopEquipment.Add(FeetEquipment.Plate());

            // Körperausrüstung hinzufügen
            shopEquipment.Add(BodyEquipment.Leather());
            shopEquipment.Add(BodyEquipment.Chain());
            shopEquipment.Add(BodyEquipment.Plate());

            return shopEquipment;
        }

        public Core.Equipment CreateEquipment()
        {
            return _equipmentPool.Get();
        }
    }
}
