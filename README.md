# Colorful Waddles

**Colorful Waddles** is a top-down 2D adventure game, developed using Unity for the Global Game Jam 2024 in 48 hours.  
Players control a goofy penguin on an adventure to make characters in a monochrome world laugh.

🎮 **Play From Here**: [https://seden.itch.io/colorful-waddles](https://seden.itch.io/colorful-waddles)

**Seden Canpolat**: I worked as the lead developer. I did the coding and worked on the story and game design.  
In terms of coding, I worked on:

- In-game interactions  
- Inventory system  
- Scene management
  
![08171-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/f2986476-c178-4fd6-a30b-ae4ae9207198)

## 🛠 Key Technical Implementations

### ScriptableObject-Based Item Matching System

Built a flexible quest system where each NPC has a personalized item requirement:

```csharp
if (other.GetComponent<Goal>().PersonalizedItem == inventory)
{
    // Correct item - complete quest
}
```

This architecture allowed team members to create and assign items without code changes, which was critical for parallel development during the jam.

### Dual-Layer Color Reveal Mechanic

Implemented the core game mechanic using a simple but effective dual-layer approach: grayscale sprites with colored versions overlaid. When players complete quests, the color layer activates, creating the visual transformation that drives the narrative.

This solution avoided shader complexity while still delivering strong visual impact under tight time constraints.

### Modular Quest State Machine

Used simple integer flags (`FlagMission = 0 / 1 / 2`) for quest tracking, allowing different quest types. Some quests are completed by giving items, while others rely on environmental interactions (such as a stone-tripping counter). This flexibility allowed rapid iteration on quest design during the jam.

### Progressive Vignette Feedback System

Linked world brightness directly to player progress:

```csharp
VinImage.LeanAlpha(0.33f * (3 - colorCount), 1f);
```

The vignette gradually fades as quests are completed, providing subtle visual feedback that reinforces the theme of “bringing color to the world” without relying on explicit UI elements.

### Third-Party Library Integration for Rapid Development

Integrated **LeanTween** for animations and **Holylib.HolySoundEffects** for audio management:

```csharp
gameObject.LeanMoveX(1.5f, 0.3f).setLoopPingPong();

walksound = SoundEffectController.PlaySFX(walkSFX)
    .SetVolume(0.5f)
    .SetLoop(true);
```

Method chaining enabled complex animations and audio control in a single line. Storing audio references allowed proper cleanup, such as stopping walking sounds when the player stops, preventing common audio overlap issues. Leveraging existing tools instead of building systems from scratch was essential to meeting the 48-hour deadline.
