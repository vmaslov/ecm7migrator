namespace ECM7.Migrator.Console
{
	/// <summary>
	/// Режим работы консоли мигратора
	/// </summary>
	public enum MigratorConsoleMode
	{
		/// <summary>
		/// Выполнить миграции
		/// </summary>
		Migrate,

		/// <summary>
		/// Отобразить список выполненных миграций
		/// </summary>
		List,


        /// <summary>
        /// Initialize <c>SchemaInfo</c> table.
        /// </summary>
        Initialize,

		/// <summary>
		/// Отобразить справку
		/// </summary>
		Help
	}
}
