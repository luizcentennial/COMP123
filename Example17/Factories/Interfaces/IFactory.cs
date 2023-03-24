namespace Example17.Factories.Interfaces {
	public interface IFactory<TReturn, TType> {
		public TReturn Create(TType type);
	}
}