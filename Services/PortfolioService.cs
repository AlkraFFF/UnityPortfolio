using UnityPortfolio.Models;

namespace UnityPortfolio.Services;

public class PortfolioService : IPortfolioService
{
    // =========================================================================
    // EDIT YOUR DATA HERE: All content updates happen inside these collections
    // =========================================================================
    private static readonly List<Project> Projects =
    [
        new(
            Id: "ARC Robot Survival",
            Title: "1",
            Subtitle: "Fast-Paced Roguelike Action in Unity 6000",
            Description: "As part of a team, I developed a dynamic action game, implementing procedural generation and a scalable wave system that keeps players engaged through unpredictable gameplay. I designed a flexible upgrade system for weapons and abilities, which encourages player retention and the creation of new character builds. Thanks to extensive optimization of both code and assets in Unity, the game maintains a consistently high frame rate, even with hundreds of active objects on screen.",
            ThumbnailUrl: "images/projects/project1.webp",
            Tags: ["Unity 3D", "C#", "Compute Shaders", "NavMesh", "DOTS"],
            Category: "3D Game",
            PlayGoogleUrl: "https://play.google.com/store/apps/details?id=com.Alkraf.ARC_Challenge"
            
            
            
        ),
        new(
            Id: "Racing Game Challenge",
            Title: "Racing Game Challenge",
            Subtitle: "High-Performance Computational Geometry Tool",
            Description: "В составе команды я разработал высокопроизводительные гиперказуальные гонки, переведя логику трафика на Unity DOTS.Я изолированно интегрировал Appodeal SDK через систему событий, настроив умное фоновое кэширование для мгновенного показа рекламы без микрофризов и просадок FPS.",
            ThumbnailUrl: "images/projects/project2.webp",
            Tags: ["Unity 3D", "C#", "Procedural Mesh", "Unity Editor Tooling"],
            Category: "3D Game"
        )
       
    ];

    private static readonly List<SkillCategory> SkillCategories =
    [
        new("Core & Gameplay",
        [
            new("Develop and maintain Unity projects for mobile platforms; work with 2D/3D assets and implement game mechanics in C# using OOP principles and Unity development best practices;", "Expert", "engine"),
            new("Work with asynchronous programming and multithreading; utilize UniTask to build high-performance systems and handle asynchronous operations;", "Expert", "csharp"),
            new("Integrate advertising and third-party SDKs, manage ad implementation, and provide ongoing support for mobile games;", "Expert", "dots"),
            new("Develop architectural solutions, contribute to the project’s technical and architectural design, and work with tools such as Zenject and Addressables", "Expert", "memory"),
            new("Manage materials, configure shaders, and handle shader-related tasks, including writing, optimizing, and implementing shaders within projects", "Expert", "memory")
        ]),
        new("Workflow & Release",
        [
            new("Participate in MVP development, prototyping, and the validation of game concepts; rapidly create functional prototypes and evaluate new mechanics", "Expert", "shader"),
            new("Fix bugs, perform debugging, analyze existing codebases, refactor and improve code, and troubleshoot emerging issues", "Expert", "urp"),
            new("Independently develop PC projects from scratch, see features and tasks through to completion, and assist in preparing builds for release and supporting the development process. • Collaborate with Product, Game Design, and QA teams; participate in discussions regarding technical solutions, feature alignment, and development requirements  ", "Expert", "vfx"),
            new("Integrate AI tools into the development, prototyping, and content preparation processes for Unity to accelerate the transition from concept to functional prototype", "Expert", "renderdoc")
        ]),
        new("Engine & Performance",
        [
            new("Optimize project performance by profiling CPU, GPU, and memory usage, and carry out tasks aimed at enhancing the performance of mobile games", "Expert", "architecture"),
            new("Manage materials, configure shaders, and handle shader-related tasks, including writing, optimizing, and implementing shaders within projects", "Expert", "pcg"),
            new("Create and lay out UI using uGUI; manage interface functionality, configuration, and updates", "Expert", "git"),
            new("Work with DOTween and integrate various services and tools throughout the project development and maintenance lifecycle", "Expert", "blender")
        ])
    ];

    public Task<IReadOnlyList<Project>> GetProjectsAsync() => Task.FromResult<IReadOnlyList<Project>>(Projects);
    public Task<IReadOnlyList<SkillCategory>> GetSkillCategoriesAsync() => Task.FromResult<IReadOnlyList<SkillCategory>>(SkillCategories);
}