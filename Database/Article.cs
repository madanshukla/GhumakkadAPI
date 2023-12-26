﻿using System;
using System.Collections.Generic;

namespace GhumakkadAPI.Database;

public partial class Article
{
    public int ArticleId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? State { get; set; }

    public int? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
