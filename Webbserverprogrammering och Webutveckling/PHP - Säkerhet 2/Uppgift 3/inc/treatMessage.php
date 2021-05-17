<?php

function treatMessage($s)
{
    return str_replace(" ", "", str_replace("\\", "", htmlspecialchars($s)));
}
