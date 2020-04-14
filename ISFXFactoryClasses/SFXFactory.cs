using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
    public class SFXFactory : ISFXFactory
    {
        private SoundEffect AquamentusDefeated;
        private SoundEffect AquamentusRoaring;
        private SoundEffect ArrowHit;
        private SoundEffect BombExplosion;
        private SoundEffect BombPlacement;
        private SoundEffect BossZapped;
        private SoundEffect DodongoDefeated;
        private SoundEffect DodongoRoaring;
        private SoundEffect DoorOpened;
        private SoundEffect EnemyShrinking;
        private SoundEffect EnemyHit;
        private SoundEffect FlamesShot;
        private SoundEffect HealthPickup;
        private SoundEffect ItemObtained;
        private SoundEffect ItemReceived;
        private SoundEffect KeyAppears;
        private SoundEffect LinkDamaged;
        private SoundEffect MagicWhistle;
        private SoundEffect Magical;
        private SoundEffect PowerZap;
        private SoundEffect RupeePickup;
        private SoundEffect SheildDeflecting;
        private SoundEffect SwordSound;
        private SoundEffect SwordZap;
        private SoundEffect TriforcePickup;
        private SoundEffect WalkingStairs;

        private static SFXFactory instance = new SFXFactory();

        public static SFXFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private SFXFactory()
        {
        }

        public void LoadAllSFX(ContentManager content)
        {
            AquamentusDefeated = content.Load<SoundEffect>("Sounds/Aquamentus_Defeated");
            AquamentusRoaring = content.Load<SoundEffect>("Sounds/Aquamentus_Roaring");
            ArrowHit = content.Load<SoundEffect>("Sounds/Arrow_Hit");
            BombExplosion = content.Load<SoundEffect>("Sounds/Bomb_Explosion");
            BombPlacement = content.Load<SoundEffect>("Sounds/Bomb_Placement");
            BossZapped = content.Load<SoundEffect>("Sounds/Boss_Zapped");
            DodongoDefeated = content.Load<SoundEffect>("Sounds/Dodongo_Defeated");
            DodongoRoaring = content.Load<SoundEffect>("Sounds/Dodongo_Roaring");
            DoorOpened = content.Load<SoundEffect>("Sounds/Door_Opened");
            EnemyShrinking = content.Load<SoundEffect>("Sounds/Enemy_Shrinking");
            EnemyHit = content.Load<SoundEffect>("Sounds/Enemy_Zapped");
            FlamesShot = content.Load<SoundEffect>("Sounds/Flames_Shot");
            HealthPickup = content.Load<SoundEffect>("Sounds/Health_Heart");
            ItemObtained = content.Load<SoundEffect>("Sounds/Item_Obtained");
            ItemReceived = content.Load<SoundEffect>("Sounds/Item_Recieved");
            KeyAppears = content.Load<SoundEffect>("Sounds/Key_Appears");
            LinkDamaged = content.Load<SoundEffect>("Sounds/Link_Damage");
            MagicWhistle = content.Load<SoundEffect>("Sounds/Magic_Whistle");
            Magical = content.Load<SoundEffect>("Sounds/Magical");
            PowerZap = content.Load<SoundEffect>("Sounds/Power_Zap");
            RupeePickup = content.Load<SoundEffect>("Sounds/Rupee_Pickup");
            SheildDeflecting = content.Load<SoundEffect>("Sounds/Sheild_Deflecting");
            SwordSound = content.Load<SoundEffect>("Sounds/Sword_Sound");
            SwordZap = content.Load<SoundEffect>("Sounds/Sword_Zap");
            TriforcePickup = content.Load<SoundEffect>("Sounds/Triforce_Reveals_Ganon");
            WalkingStairs = content.Load<SoundEffect>("Sounds/Walking_Stairs");
        }

        public void PlayAquamentusDefeated()
        {
            AquamentusDefeated.Play();
        }

        public void PlayAquamentusRoaring()
        {
            AquamentusRoaring.Play();
        }

        public void PlayArrowHit()
        {
            ArrowHit.Play();
        }

        public void PlayBombExplosion()
        {
            BombExplosion.Play();
        }

        public void PlayBombPlacement()
        {
            BombPlacement.Play();
        }

        public void PlayBossZapped()
        {
            BossZapped.Play();
        }

        public void PlayDodongoDefeated()
        {
            DodongoDefeated.Play();
        }

        public void PlayDodongoRoaring()
        {
            DodongoRoaring.Play();
        }

        public void PlayDoorOpened()
        {
            DoorOpened.Play();
        }

        public void PlayEnemyShrinking()
        {
            EnemyShrinking.Play();
        }
        public void PlayEnemyHit()
        {
            EnemyHit.Play();
        }
        public void PlayFlamesShot()
        {
            FlamesShot.Play();
        }

        public void PlayHealthPickup()
        {
            HealthPickup.Play();
        }
        public void PlayItemObtained()
        {
            ItemObtained.Play();
        }

        public void PlayItemRecieved()
        {
            ItemReceived.Play();
        }

        public void PlayKeyAppears()
        {
            KeyAppears.Play();
        }

        public void PlayLinkDamaged()
        {
            LinkDamaged.Play();
        }

        public void PlayMagicWhistle()
        {
            MagicWhistle.Play();
        }

        public void PlayMagical()
        {
            Magical.Play();
        }

        public void PlayPowerZap()
        {
            PowerZap.Play();
        }

        public void PlayRupeePickup()
        {
            RupeePickup.Play();
        }
        public void PlaySheildDeflecting()
        {
            SheildDeflecting.Play();
        }

        public void PlaySwordSound()
        {
            SwordSound.Play();
        }

        public void PlaySwordZap()
        {
            SwordZap.Play();
        }

        public void PlayTriforcePickup()
        {
            TriforcePickup.Play();
        }

        public void PlayWalkingStairs()
        {
            WalkingStairs.Play();
        }
    }
}
