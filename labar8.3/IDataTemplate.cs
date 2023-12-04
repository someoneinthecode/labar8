using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

// Інтерфейс для шаблонів даних
public interface IDataTemplate
{
    IDataTemplate Clone();
}