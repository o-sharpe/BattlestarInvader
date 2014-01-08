using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlestar
{
	public static class BattleStar
	{
		#region Declarations

		public static Sprite BaseSprite;
		public static List<Sprite> TurretSprites = new List<Sprite>();
		public static Vector2 baseAngle = Vector2.Zero;
		private static float playerSpeed = 90f;
		private static Rectangle scrollArea = new Rectangle(150, 100, 500, 400);

		#endregion

		#region Properties

		//public static Vector2 PathingNodePosition
		//{
		//	get { return TileMap.GetSquareAtPixel(BaseSprite.WorldCenter); }
		//}

		#endregion

		#region Initialization

		public static void Initialize(Texture2D texture, Rectangle baseInitialFrame, int baseFrameCount, Texture2D textureTurret, Rectangle turretInitialFrame, Vector2 worldLocation)
		{
			int frameWidth = baseInitialFrame.Width;
			int frameHeight = baseInitialFrame.Height;

			BaseSprite = new Sprite(worldLocation, texture, baseInitialFrame, Vector2.Zero);
			BaseSprite.BoundingXPadding = 4;
			BaseSprite.BoundingYPadding = 4;
			BaseSprite.AnimateWhenStopped = false;
			for (int x = 1; x < baseFrameCount; x++)
				BaseSprite.AddFrame(new Rectangle(baseInitialFrame.X + (frameHeight * x), baseInitialFrame.Y, frameWidth, frameHeight));

			for (int x = 0; x < 4; x++ )
				TurretSprites.Add(new Sprite(new Vector2(worldLocation.X + 20 + x * 50, worldLocation.Y + 5), textureTurret, turretInitialFrame, Vector2.Zero));
		}

		#endregion

		#region Update and Draw !

		public static void Update(GameTime gameTime)
		{
			//InputManager.HandleMouseInput(Mouse.GetState(), TurretSprite);	
		}

		public static void Draw(SpriteBatch spriteBatch)
		{
			BaseSprite.Draw(spriteBatch);
			for (int x = 0; x < 4; x++)
				TurretSprites[x].Draw(spriteBatch);
		}

		#endregion
	}
}
