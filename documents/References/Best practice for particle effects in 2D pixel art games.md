# [Best practice for particle effects in 2D pixel art games by Sersch7](https://imgur.com/gallery/z4Boura)

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/00_mfXNhCy.gif)

There are countless tutorials out there how to create cool particle effects. There are also many ready to use packages available. Most of those are not made for pixel art games and will mostly look out of place. While particle effects are very popular in 3D games, they are less common in 2D pixel art games. I think a reason is that particle effects were barely used during the 8bit and 16bit era. But I think they can add quite a lot visually to modern pixel art games.

The examples I provide in this post are from my game "Monster Sanctuary" - it is still in development but you can check out the demo http://store.steampowered.com/app/814370/Monster_Sanctuary

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/01_bt7cxpW.gif)

In this tutorial I will provide a list of tips and best practice how to make particle effects look cool and homogeneous in pixel art games. The examples I will provide are based on Unity Engine but you should be able to apply them onto mostly any other engines/frameworks.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/02_w30Qhix.gif)

1. Don’t use blurry & gradient textures

When using particle effects in pixel art games, you want them to look low resolution, pixelated and sharp, not blurry. Often the particle effects can look out of place because they look high res or blurry while your pixel art looks sharp and pixelated.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/03_5yBX7M1.png)

The default texture used in Unity is a blurry gradient circle and is rather useless for pixel art particle effects.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/04_wCGQhGt.png)

Use sharp pixel art textures as your base.  I use mostly those both textures for the majority of my particle effects. Of course you can come up with some even cooler effects with some more complex pixel art textures.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/05_LRjA4S7.png)

2. Don’t use anti aliasing

Make sure that your texture renderer for your particles is setup to not use anti aliasing as this will make them look blurry when scaled. Select "Point" for Filter Mode in Unity.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/06_koUE8go.png)

3. Use reduced amount of colors or seperated areas for different colors

A popular rule for pixel art games is to use a reduced amount of different colors. This makes the pixel art more readable. This is also useful tip for pixel art particle effects: Often they will look more fitting to the game if you use a reduced amount of colors or seperate them into areas. You can, for example, make multiple layers each with their own emitters, emitting different colors of particles. In the upper example I have three emitters (the three blue circle outlines) - the biggest one is responsible for emitting dark orange and red particles and is in the background. The middle one is responsible for emitting yellow particles. The smallest one is in the front and is responsible for emitting very bright white-yellowish particles.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/07_xhZ1ZPP.png)

If you have color transitions for your particles, you can try having them be very short instead of smooth gradients.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/08_O9yC1mp.gif)

4. Render the game to a low resolution

The above image shows, how the particle effect looks in Unity Editor.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/09_15Pgh5N.gif)

This is how it actually looks ingame. Apossibility of achieving this is rendering your whole game onto a texture of your lowest possible game resolution (so every pixel and sprite has a scaling of 1) and then scaling this texture up to the resolution to be displayed on the screen. Also, this will make the game look authentic and old school even when you scale/rotate your sprites.
Of course this is a style choice and sometimes you rather want the freedom a high resolution provides (like having high res fonts in your menus) – if you are set in going this route, try not scaling your particles too much (especially downscaling can look like out of place rather fast) - or render your particle effects onto a low resolution texture first and then display that texture up-scaled.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/10_ANPFXxi.gif)

5. Use rather short lifetimes for your particles

One way to have your particle effects not look boring is by having the particles have a rather short lifetime (and emit them more frequently instead). Most of the time the lifetime of the particles I use is set around or below 1 second.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/11_egJtgXE.gif)

6. Be Dynamic

Particle effects look less exciting if the single particles look rather static. Always have your pixels move in some way and sometimes also scale, rotate or change color to look more dynamic.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/12_dYgnTEb.gif)

One cool trick is to decelerate your movement. For many particle effects, for example explosion, or splatter like effects – instead of having linear movement, it will look snappy if you start with high initial speed and then decelerate your particles.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/13_9AnZj7F.png)

You can easily achieve this by using "Limit Velocity over Lifetime" with a curve in Unity. Don't go all the way down to zero, just a small value, but let them still move a little.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/14_fnCqwrm.gif)

7. Cluster your particles (using sub emitters)

One technique that can make certain particle effects look more natural is using sub emitters. Instead of directly emitting your particles, your main emitter emits sub emitters and they emit the actual particles. This will make your particle effects look like they are made out of clusters (a Look that is very common in nature).

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/15_XbN94XI.gif)

8. Use moving particle emitters

You can achieve cool effects by moving your particle emitters. For example when creating fireballs.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/16_Ep9e4yM.gif)

9. Use the trail feature

In Unity (and many other particle editors) you can set your particles to look like trails, based on the particle movement. This can be used to achieve quite some cool looking effects.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/17_N1By7Qv.png)

Trails is a modifier for your particles in Unity.

![](Best%20practice%20for%20particle%20effects%20in%202D%20pixel%20art%20games/images/18_L92kbJV.gif)

10. Be creative

Be creative how you use particle effects. I use them for example to have certain monsters have a unique look.

If you liked this tutorial, follow me on twitter https://twitter.com/moi_rai_

Or check out the game those examples are taken from: https://monster-sanctuary.com/