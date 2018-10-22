﻿namespace CalcWin.DataAccess.Model
{
    public interface IElement
    {
        int Id { get; set; }
        string Name { get; set; }
        string NormalizedName { get; set; }
    }
}