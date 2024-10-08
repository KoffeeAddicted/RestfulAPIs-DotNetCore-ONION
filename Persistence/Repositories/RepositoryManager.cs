using Domain;
using Domain.Entities;
using Domain.RepositoryInterfaces;

namespace Persistence.Repositories;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<IStoryRepository> _lazyStoryRepository;
    private readonly Lazy<IStoryCategoryRepository> _lazyStoryCategoryRepository;
    private readonly Lazy<IUserRepository> _lazyUserRepository;
    private readonly Lazy<IWishlistRepository> _lazyWishlistRepository;
    private readonly Lazy<IHistoryRepository> _lazyHistoryRepository;
    private readonly Lazy<ICommentRepository> _lazyCommentRepository;
    private readonly Lazy<IAudioRepository> _lazyAudioRepository;
    private readonly Lazy<IBannerRepository> _lazyBannerRepository;
    public RepositoryManager(IGenericRepository<Story> genericStoryRepository,
        IGenericRepository<StoryCategory> genericStoryCategoryRepository, 
        IGenericRepository<User> genericUserRepository, 
        IGenericRepository<Wishlist> genericWishlistRepository, 
        IGenericRepository<History> genericHistoryRepository, 
        IGenericRepository<Comment> genericCommentRepository,
        IGenericRepository<Audio> genericAudioRepository,
        IGenericRepository<Banner> genericBannerRepository)
    {
        _lazyStoryRepository = new Lazy<IStoryRepository>(() => new StoryRepository(genericStoryRepository));
        _lazyStoryCategoryRepository = new Lazy<IStoryCategoryRepository>(() => new StoryCategoryRepository(genericStoryCategoryRepository));
        _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(genericUserRepository));
        _lazyWishlistRepository =  new Lazy<IWishlistRepository>(() => new WishlistRepository(genericWishlistRepository));
        _lazyHistoryRepository = new Lazy<IHistoryRepository>(() => new HistoryRepository(genericHistoryRepository));
        _lazyCommentRepository = new Lazy<ICommentRepository>(() => new CommentRepository(genericCommentRepository));
        _lazyAudioRepository = new Lazy<IAudioRepository>(() => new AudioRepository(genericAudioRepository));
        _lazyBannerRepository = new Lazy<IBannerRepository>(() => new BannerRepository(genericBannerRepository));
    }

    public IStoryRepository StoryRepository => _lazyStoryRepository.Value;
    public IUserRepository UserRepository => _lazyUserRepository.Value;
    public IStoryCategoryRepository StoryCategoryRepository => _lazyStoryCategoryRepository.Value;
    public IWishlistRepository WishlistRepository => _lazyWishlistRepository.Value;
    public IHistoryRepository HistoryRepository => _lazyHistoryRepository.Value;
    public ICommentRepository CommentRepository => _lazyCommentRepository.Value;
    public IAudioRepository AudioRepository => _lazyAudioRepository.Value;
    public IBannerRepository BannerRepository => _lazyBannerRepository.Value;
}