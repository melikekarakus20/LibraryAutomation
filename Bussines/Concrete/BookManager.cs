using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Bussines.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Bussines.Concrete
{
	public class BookManager : IBookService
	{
		private IBookDal _bookDal;

		public BookManager(IBookDal bookDal)
		{
			_bookDal = bookDal;
		}

		public void Add(Book book)
		{
			//throw new NotImplementedException();
			//EfBookDal efBookDal = new EfBookDal();
			_bookDal.Add(book);
			if (_bookDal.Get(b=>b.Name == book.Name && b.AuthorId==book.AuthorId ) == null)
			{
				_bookDal.Add(book);
			}
			throw new Exception("Bu kitap adı zaten var");
		}

		public void Delete(Book book)
		{
			//throw new NotImplementedException();
			_bookDal.Delete(book);
		}

		public List<Book> GetAll()
		//{
			//throw new NotImplementedException();
		return public Book GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Book> GetByAuthorId(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Book book)
		{
			throw new NotImplementedException();
		}

		_bookDal.GetList().ToList();
		}

		public List<Book> GetByAuthorId(int id)
		{
		//throw new NotImplementedException();
		return _bookDal.GetList(b => b.AuthorId == id).ToList();
		}

		public Book GetById(int id)
		//{
		//	throw new NotImplementedException();
		return _bookDal.Get(b => b.Id == id);
		}

		public void Update(Book book)
		{
	_bookDal.Update(book);
	

			//throw new NotImplementedException();
		}
	}

}
