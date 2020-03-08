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
            get => this.hp_;

            set => this.SetProperty(ref this.hp_, value);
        }

        /// <summary>攻撃 を取得、設定</summary>
        private int attack_;
        /// <summary>攻撃 を取得、設定</summary>
        public int Attack
        {
            get => this.attack_;

            set => this.SetProperty(ref this.attack_, value);
        }

        /// <summary>防御 を取得、設定</summary>
        private int block_;
        /// <summary>防御 を取得、設定</summary>
        public int Block
        {
            get => this.block_;

            set => this.SetProperty(ref this.block_, value);
        }

        /// <summary>とくこう を取得、設定</summary>
        private int contact_;
        /// <summary>とくこう を取得、設定</summary>
        public int Contact
        {
            get => this.contact_;

            set => this.SetProperty(ref this.contact_, value);
        }

        /// <summary>とくぼう を取得、設定</summary>
        private int defence_;
        /// <summary>とくぼう を取得、設定</summary>
        public int Defence
        {
            get => this.defence_;

            set => this.SetProperty(ref this.defence_, value);
        }

        /// <summary>すばやさ を取得、設定</summary>
        private int speed_;
        /// <summary>すばやさ を取得、設定</summary>
        public int Speed
        {
            get => this.speed_;

            set => this.SetProperty(ref this.speed_, value);
        }
    }
}
