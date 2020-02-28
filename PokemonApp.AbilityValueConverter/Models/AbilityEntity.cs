using Prism.Mvvm;

namespace PokemonApp.AbilityValueConverter.Models
{
    public class AbilityEntity : BindableBase
    {
        /// <summary>HP を取得、設定</summary>
        private int hp_;
        /// <summary>HP を取得、設定</summary>
        public int Hp
        {
            get { return this.hp_; }
            set { this.SetProperty(ref hp_, value); }
        }

        /// <summary>攻撃 を取得、設定</summary>
        private int attack_;
        /// <summary>攻撃 を取得、設定</summary>
        public int Attack
        {
            get { return this.attack_; }
            set { this.SetProperty(ref attack_, value); }
        }

        /// <summary>防御 を取得、設定</summary>
        private int block_;
        /// <summary>防御 を取得、設定</summary>
        public int Block
        {
            get { return this.block_; }
            set { this.SetProperty(ref block_, value); }
        }

        /// <summary>とくこう を取得、設定</summary>
        private int contact_;
        /// <summary>とくこう を取得、設定</summary>
        public int Contact
        {
            get { return this.contact_; }
            set { this.SetProperty(ref contact_, value); }
        }

        /// <summary>とくぼう を取得、設定</summary>
        private int defence_;
        /// <summary>とくぼう を取得、設定</summary>
        public int Defence
        {
            get { return this.defence_; }
            set { this.SetProperty(ref defence_, value); }
        }

        /// <summary>すばやさ を取得、設定</summary>
        private int speed_;
        /// <summary>すばやさ を取得、設定</summary>
        public int Speed
        {
            get { return this.speed_; }
            set { this.SetProperty(ref speed_, value); }
        }
    }
}
