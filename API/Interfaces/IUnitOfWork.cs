namespace API.Interfaces
{
  public interface IUnitOfWork
  {
    IUserRepository userRepository { get; }
    IMessageRepository messageRepository { get; }
    ILikesRepository LikesRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
  }
}