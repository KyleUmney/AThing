using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using AThing.Sprites;
using Microsoft.Xna.Framework.Input;

namespace AThing.States
{
  public class GameState : State
  {
    public List<Sprite> _sprites;

    private Spawner _spawner;

    public GameState(Game1 game, ContentManager content)
      : base(game, content)
    {

    }
    public override void LoadContent()
    {
      var playerTexture = _content.Load<Texture2D>("Sprites/player");
      var enemyTexture = _content.Load<Texture2D>("Sprites/Enemy");

      _sprites = new List<Sprite>()
      {
        new Player(playerTexture)
        {
          Colour = Color.Red,
          Position = new Vector2(Game1.ScreenWidth / 2,Game1.ScreenHeight / 2),
          Layer = 0.0f,
          Input = new Models.Input()
          {
            Up = Keys.W,
            Down = Keys.S,
            Left = Keys.A,
            Right = Keys.D,
          },
          Health = 100,
        },
        new CrazyBug(enemyTexture)
        {
          Colour = Color.Blue,
          Position = new Vector2(0,0),
          Layer = 0.1f,
          Health = 100,
        }
      };
      _spawner = new Spawner(_content, enemyTexture);
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Begin(SpriteSortMode.FrontToBack);

      foreach (var sprite in _sprites)
        sprite.Draw(gameTime, spriteBatch);

      spriteBatch.End();
    }

    public override void PostUpdate(GameTime gameTime)
    {

    }

    public override void Update(GameTime gameTime)
    {
      foreach (var sprite in _sprites)
        sprite.Update(gameTime);
    }
  }
}
