﻿using Entity.Concrete;

namespace Business.Abstract;

public interface ICommentService : IGenericService<Comment>
{
    List<Comment> GetDestinationById(Guid id);
    
    List<Comment> TGetListWithDestination();
    
    List<Comment> GetListWithDestinationAndApplicationUser();
}