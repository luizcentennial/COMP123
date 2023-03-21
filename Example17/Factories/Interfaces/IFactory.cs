namespace Example17.Factories.Interfaces {
	public interface IFactory<T, R> {
		public T Create(R type);
	}
}
