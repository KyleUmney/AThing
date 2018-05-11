using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AThing.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AThing.States
{
  class MenuState : State
  {
    private List<Component> _components;

    public MenuState(Game1 game, ContentManager content) 
      : base(game, content)
    {
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      
    }

    public override void LoadContent()
    {
      var StartButton = _content.Load<Texture2D>("Buttons/StartButton");

      _components = new List<Component>()
      {
        new Sprite(_content.Load<Texture2D>("Background/MenuBackGround"))
        {
          Layer = 0f,
          Position = new Vector2(Game1.ScreenHeight /2, Game1.ScreenWidth /2),
        },
      };
    }

    public override void PostUpdate(GameTime gameTime)
    {
      
    }

    public override void Update(GameTime gameTime)
    {
     
    }
  }
}
