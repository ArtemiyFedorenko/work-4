﻿public interface IUser1
{
    int Age { get; }
    DateTime CreationDate { get; }
    string Login { get; }
    string Name { get; }
    string Surname { get; }

    void PrintInfo();
}